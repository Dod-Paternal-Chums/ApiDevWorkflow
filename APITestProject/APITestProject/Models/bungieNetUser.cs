using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Models
{
    class bungieNetUser
    {
        public int membershipId { get; set; }
        public string uniqueName { get; set; }
        public string normalizedName { get; set; }
        public string displayName { get; set; }
        public int profilePicture { get; set; }
        public int profileTheme { get; set; }
        public int userTitle { get; set; }
        public int successMessageFlags { get; set; }
        public bool isDeleted { get; set; }
        public string about { get; set; }
        public string firstAccess { get; set; }
        public string lastUpdate { get; set; }
        public int legacyPortalUID { get; set; }
        public UserToUserContext context { get; set; }
        public string psnDisplayName { get; set; }
        public string xboxDisplayName { get; set; }
        public string dbDisplayName { get; set; }
        public bool? showActivity { get; set; }
        public string locale { get; set; }
        public bool localeInheritDefault { get; set; }
        public int? lastBanReportId { get; set; }
        public bool showGroupMessaging { get; set; }
        public string profilePicturePath { get; set; }
        public string profilePictureWidePath { get; set; }
        public string profileThemeName { get; set; }
        public string userTitleDisplay { get; set; }
        public string statusText { get; set; }
        public DateTime statusDate { get; set; }
        public DateTime? profileBaneExpire { get; set; }
        public string blizzardDisplayName { get; set; }
    }
}
