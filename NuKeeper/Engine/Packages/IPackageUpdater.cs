﻿using System.Threading.Tasks;
using NuKeeper.Git;
using NuKeeper.RepositoryInspection;

namespace NuKeeper.Engine.Packages
{
    public interface IPackageUpdater
    {
        Task UpdatePackageInProjects(
            IGitDriver git,
            PackageUpdateSet updateSet,
            RepositoryData repository);
    }
}