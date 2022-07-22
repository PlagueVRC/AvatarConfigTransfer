using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatarConfigTransfer
{
    internal class VRCAPI
    {
        internal class UnityPackage
        {
            internal string assetUrl;
            internal int assetVersion;
            internal DateTime created_at;
            internal string id;
            internal string platform;
            internal string pluginUrl;
            internal long unitySortNumber;
            internal string unityVersion;
        }

        internal class AvatarInfo
        {
            internal string assetUrl;
            internal string authorId;
            internal string authorName;
            internal DateTime created_at;
            internal string description;
            internal bool featured;
            internal string id;
            internal string imageUrl;
            internal string name;
            internal string releaseStatus;
            internal string[] tags;
            internal string thumbnailImageUrl;
            internal string unityPackageUrl;
            internal UnityPackage[] unityPackages;
            internal DateTime updated_at;
            internal int version;
        }
    }
}
