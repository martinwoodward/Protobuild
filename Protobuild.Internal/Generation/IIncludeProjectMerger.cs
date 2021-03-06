﻿using System.Collections.Generic;
using System.Xml;

namespace Protobuild
{
    public interface IIncludeProjectMerger
    {
        void MergeInReferencesAndPropertiesForIncludeProjects(List<LoadedDefinitionInfo> documents, XmlDocument projectDoc, string targetPlatform);
    }
}

