/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha
 * 
 */

using Piranha.Security;
using System.Collections.Generic;

namespace Piranha.Azure
{
    /// <summary>
    /// The identity module.
    /// </summary>
    public class BlobStorageModule : Extend.IModule
    {
        /// <summary>
        /// Gets the Author
        /// </summary>
        public string Author => "Piranha";

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name => "Piranha.Azure.BlobStorage";

        /// <summary>
        /// Gets the Version
        /// </summary>
        public string Version => Piranha.Utils.GetAssemblyVersion(this.GetType().Assembly);

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description => "Module for storing media assets on Azure Blob Storage.";

        /// <summary>
        /// Gets the package url.
        /// </summary>
        public string PackageURL => "https://www.nuget.org/packages/Piranha.Azure.BlobStorage";

        /// <summary>
        /// Gets/sets the icon URL.
        /// </summary>
        public string IconUrl => "http://piranhacms.org/assets/twitter-shield.png";

        /// <summary>
        /// Initializes the module.
        /// </summary>
        public virtual void Init() { }
    }
}