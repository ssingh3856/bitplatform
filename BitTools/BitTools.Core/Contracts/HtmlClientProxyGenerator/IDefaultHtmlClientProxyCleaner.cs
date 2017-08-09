﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using System.Threading.Tasks;

namespace BitTools.Core.Contracts.HtmlClientProxyGenerator
{
    public interface IDefaultHtmlClientProxyCleaner
    {
        Task DeleteCodes(Workspace workspace, string solutionFilePath, IList<string> projectNames);
    }
}