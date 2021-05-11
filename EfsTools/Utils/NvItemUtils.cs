﻿using System;
using System.Collections.Generic;
using System.IO;
using EfsTools.Items;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EfsTools.Utils
{
    internal static class NvItemUtils
    {
        public static HashSet<string> GetConfigs(TextReader reader)
        {
            var result = new HashSet<string>();
            var str = reader.ReadToEnd();
            var jsonObj = (JObject) JsonConvert.DeserializeObject(str);

            foreach (var jsonItem in jsonObj)
            {
                var type = jsonItem.Key;
                result.Add(type);
            }

            return result;
        }

        public static Dictionary<string, object> PhoneLoadItems(QcdmManager manager, int subscription, Logger logger, bool verbose,
            HashSet<string> configItems)
        {
            var items = new Dictionary<string, object>();
            foreach (var filePath in ItemsFactory.SupportedEfsFilePaths)
            {
                var realFilePath = PathUtils.GetEfsFilePath(filePath, subscription);
                var itemType = ItemsFactory.GetEfsFileType(filePath);
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    if (manager.Efs.FileExists(realFilePath))
                    {
                        using (var stream = FileUtils.PhoneOpenReadMemory(manager, realFilePath))
                        {
                            if (verbose)
                            {
                                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, filePath));
                            }
                            var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                            items.Add(itemType.Name, item);
                            stream.Close();
                        }
                    }
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var itemType = ItemsFactory.GetNvItemType(nvItemId);
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    using (var stream = NvOpenRead(manager, (ushort) nvItemId))
                    {
                        if (stream != null)
                        {
                            if (verbose)
                            {
                                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, itemType.Name));
                            }
                            var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                            items.Add(itemType.Name, item);
                            stream.Close();
                        }
                    }
                }
            }

            return items;
        }

        public static Dictionary<string, object> PhoneLoadItems(QcdmManager manager, int subscription, Logger logger, bool verbose)
        {
            var items = new Dictionary<string, object>();
            foreach (var filePath in ItemsFactory.SupportedEfsFilePaths)
            {
                var realFilePath = PathUtils.GetEfsFilePath(filePath, subscription);
                if (manager.Efs.FileExists(realFilePath))
                {
                    var itemType = ItemsFactory.GetEfsFileType(filePath);
                    using (var stream = FileUtils.PhoneOpenReadMemory(manager, realFilePath))
                    {
                        if (verbose)
                        {
                            logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, filePath));
                        }
                        var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                        items.Add(itemType.Name, item);
                        stream.Close();
                    }
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var itemType = ItemsFactory.GetNvItemType(nvItemId);
                using (var stream = NvOpenRead(manager, (ushort) nvItemId))
                {
                    if (stream != null)
                    {
                        if (verbose)
                        {
                            logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, itemType));
                        }
                        var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                        items.Add(itemType.Name, item);
                        stream.Close();
                    }
                }
            }

            return items;
        }

        public static void PhoneSaveItems(QcdmManager manager, int subscription, Dictionary<string, object> items,
            Logger logger, bool verbose)
        {
            var efs = manager.Efs;
            foreach (var item in items)
            {
                var type = item.Value.GetType();
                var fileAttribute = EfsFileAttributeUtils.Get(type);
                if (fileAttribute == null)
                {
                    var nvItemIdAttribute = NvItemIdAttributeUtils.Get(type);
                    if (nvItemIdAttribute != null && nvItemIdAttribute.Id <= ushort.MaxValue)
                    {
                        if (verbose)
                        {
                            logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, type.Name));
                        }
                        using (var memoryStream = new MemoryStream())
                        {
                            ItemsBinarySerializer.Serialize(item.Value, memoryStream);
                            memoryStream.Flush();
                            memoryStream.Position = 0;
                            using (var stream = NvOpenWrite(manager, (ushort)nvItemIdAttribute.Id))
                            {
                                StreamUtils.Copy(memoryStream, stream);
                                stream.Flush();
                                stream.Close();
                            }
                            memoryStream.Close();
                        }
                    }
                }
                else
                {
                    var path = PathUtils.GetEfsFilePath(fileAttribute.Path, subscription);
                    if (verbose)
                    {
                        logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, fileAttribute.Path));
                    }

                    if (efs.FileExists(path))
                    {
                        efs.DeleteFile(path);
                    }

                    using (var memoryStream = new MemoryStream())
                    {
                        ItemsBinarySerializer.Serialize(item.Value, memoryStream);
                        memoryStream.Flush();
                        memoryStream.Position = 0;
                        using (var stream = fileAttribute.IsItemFile
                        ? FileUtils.PhoneItemCreateWrite(manager, path, fileAttribute.Permissions, logger)
                        : FileUtils.PhoneCreateWrite(manager, path, fileAttribute.Permissions, logger))
                        {
                            StreamUtils.Copy(memoryStream, stream);
                            stream.Flush();
                            stream.Close();
                        }
                        memoryStream.Close();
                    }
                }
            }
        }

        public static Dictionary<string, object> LocalLoadItems(string directoryPath, int subscription, Logger logger, bool verbose,
            HashSet<string> configItems)
        {
            var items = new Dictionary<string, object>();
            foreach (var fileUnixPath in ItemsFactory.SupportedEfsFilePaths)
            {
                var itemType = ItemsFactory.GetEfsFileType(fileUnixPath);
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    var filePath = PathUtils.GetEfsFilePath(fileUnixPath, subscription);
                    filePath = filePath.Replace('/', '\\');
                    var fileAttribute = EfsFileAttributeUtils.Get(itemType);
                    var path = fileAttribute == null
                        ? $"{directoryPath}{filePath}"
                        : PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions,
                            fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File, false);
                    if (!File.Exists(path))
                    {
                        path = $"{directoryPath}{filePath}";
                        path = PathUtils.FindFile($"{path}__");
                    }
                    if (!File.Exists(path))
                    {
                        path = $"{directoryPath}{filePath}";
                    }

                    if (File.Exists(path))
                    {
                        using (var stream = FileUtils.LocalOpenRead(path))
                        {
                            if (verbose)
                            {
                                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, path));
                            }
                            var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                            items.Add(itemType.Name, item);
                            stream.Close();
                        }
                    }
                    else
                    {
                        var newItem = Activator.CreateInstance(itemType);
                        items.Add(itemType.Name, newItem);
                    }
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var itemType = ItemsFactory.GetNvItemType(nvItemId);
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    var nvItemFileName = PathUtils.GetNvItemFileName((ushort) nvItemId);
                    var path = Path.Combine(directoryPath, nvItemFileName);
                    if (File.Exists(path))
                    {
                        using (var stream = FileUtils.LocalOpenRead(path))
                        {
                            if (verbose)
                            {
                                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, itemType));
                            }
                            var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                            items.Add(itemType.Name, item);
                            stream.Close();
                        }
                    }
                    else
                    {
                        var newItem = Activator.CreateInstance(itemType);
                        items.Add(itemType.Name, newItem);
                    }
                }
            }

            return items;
        }

        public static Dictionary<string, object> LocalLoadItems(string directoryPath, int subscription, Logger logger, bool verbose)
        {
            var items = new Dictionary<string, object>();
            foreach (var fileUnixPath in ItemsFactory.SupportedEfsFilePaths)
            {
                var itemType = ItemsFactory.GetEfsFileType(fileUnixPath);
                var fileAttribute = EfsFileAttributeUtils.Get(itemType);
                var filePath = PathUtils.GetEfsFilePath(fileUnixPath, subscription);
                filePath = filePath.Replace('/', '\\');
                var path = fileAttribute == null
                    ? $"{directoryPath}{filePath}"
                    : PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions,
                        fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File, false);
                if (!File.Exists(path))
                {
                    path = $"{directoryPath}{filePath}";
                    path = PathUtils.FindFile($"{path}__");
                }
                if (!File.Exists(path))
                {
                    path = $"{directoryPath}{filePath}";
                }

                if (File.Exists(path))
                {
                    using (var stream = FileUtils.LocalOpenRead(path))
                    {
                        if (verbose)
                        {
                            logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, path));
                        }
                        var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                        items.Add(itemType.Name, item);
                        stream.Close();
                    }
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var itemType = ItemsFactory.GetNvItemType(nvItemId);
                var nvItemFileName = PathUtils.GetNvItemFileName((ushort) nvItemId);
                var path = Path.Combine(directoryPath, nvItemFileName);
                if (File.Exists(path))
                {
                    using (var stream = FileUtils.LocalOpenRead(path))
                    {
                        if (verbose)
                        {
                            logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, itemType));
                        }
                        var item = ItemsBinarySerializer.Deserialize(stream, itemType);
                        items.Add(itemType.Name, item);
                        stream.Close();
                    }
                }
            }

            return items;
        }

        public static void LocalSaveItem(string directoryPath, int subscription, object item,
            Logger logger, bool verbose)
        {
            var type = item.GetType();
            var fileAttribute = EfsFileAttributeUtils.Get(type);
            if (fileAttribute == null)
            {
                var nvItemIdAttribute = NvItemIdAttributeUtils.Get(type);
                if (nvItemIdAttribute != null && nvItemIdAttribute.Id <= ushort.MaxValue)
                {
                    if (verbose)
                    {
                        logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, type.Name));
                    }
                    var nvItemFileName = PathUtils.GetNvItemFileName((ushort)nvItemIdAttribute.Id);
                    var path = Path.Combine(directoryPath, nvItemFileName);
                    using (var stream = FileUtils.LocalCreateWrite(path))
                    {
                        ItemsBinarySerializer.Serialize(item, stream);
                        stream.Flush();
                        stream.Close();
                    }
                }
            }
            else
            {
                if (verbose)
                {
                    logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, fileAttribute.Path));
                }
                var filePath = PathUtils.GetEfsFilePath(fileAttribute.Path, subscription);
                var entryType = fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File;
                var path = PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions, entryType,
                    false);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (var stream = FileUtils.LocalCreateWrite(path))
                {
                    ItemsBinarySerializer.Serialize(item, stream);
                    stream.Flush();
                    stream.Close();
                }
            }
        }

        public static void LocalSaveItems(string directoryPath, int subscription, Dictionary<string, object> items,
            Logger logger, bool verbose)
        {
            foreach (var item in items)
            {
                if (item.Value != null)
                {
                    LocalSaveItem(directoryPath, subscription, item.Value, logger, verbose);
                }
            }
        }

        public static void PhoneDownloadNvItems(QcdmManager manager, string path, Logger logger)
        {
            logger.LogInfo(string.Format(Strings.QcdmDownloadingNvItems));
            for (ushort nvItemId = 1; nvItemId < ushort.MaxValue; ++nvItemId)
            {
                PhoneDownloadNvItem(manager, path, nvItemId, logger);
            }
        }

        public static void PhoneUploadNvItems(QcdmManager manager, string path, Logger logger)
        {
            logger.LogInfo(string.Format(Strings.QcdmUploadingNvItems));
            for (ushort nvItemId = 1; nvItemId < ushort.MaxValue; ++nvItemId)
            {
                PhoneUploadNvItem(manager, path, nvItemId, logger);
            }
        }

        private static void PhoneDownloadNvItem(QcdmManager manager, string path, ushort nvItemId, Logger logger)
        {
            var filePath = string.Empty;
            try
            {
                filePath = PathUtils.GetNvItemFileName(nvItemId);
                filePath = Path.Combine(path, filePath);
                using (var input = NvOpenRead(manager, nvItemId))
                {
                    if (input != null)
                    {
                        using (var output = FileUtils.LocalCreateWrite(filePath))
                        {
                            StreamUtils.Copy(input, output);
                            output.Flush();
                            output.Close();
                        }
                        input.Close();
                    }
                }
            }
            catch
            {
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }

        private static void PhoneUploadNvItem(QcdmManager manager, string path, ushort nvItemId, Logger logger)
        {
            try
            {
                var filePath = PathUtils.GetNvItemFileName(nvItemId);
                filePath = Path.Combine(path, filePath);
                if (File.Exists(filePath))
                {
                    using (var input = FileUtils.LocalOpenRead(filePath))
                    {
                        using (var output = NvOpenWrite(manager, nvItemId))
                        {
                            StreamUtils.Copy(input, output);
                            output.Flush();
                            output.Close();
                        }

                        input.Close();
                    }
                }
            }
            catch
            {
            }
        }

        private static Stream NvOpenRead(QcdmManager manager, ushort nvItemId)
        {
            try
            {
                var data = manager.Nv.Read(nvItemId);
                return new MemoryStream(data);
            }
            catch
            {
                return null;
            }
        }

        private static Stream NvOpenWrite(QcdmManager manager, ushort nvItemId)
        {
            try
            {
                return new QcdmManagerNvWriteStreamAdapter(manager, nvItemId);
            }
            catch
            {
                return null;
            }
        }
    }
}