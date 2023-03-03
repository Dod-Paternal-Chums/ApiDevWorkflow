using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Models
{
    class generalUser
    {
        // Type: GeneralUser

        // Type: integer:int64
        public static int membershipId;
        // Type: string
        public static string uniqueName;
        // Type: string
        public static string normalizedName;
        // Type: string
        public static string displayName;
        // Type: integer:int32
        public static int profilePicture;
        // Type: integer:int32
        public static int profileTheme;
        // Type: integer:int32
        public static int userTitle;
        // Type: integer:int64
        public static int successMessageFlags;
        // Type: boolean
        public static bool isDeleted;
        // Type: string
        public static string about;
        // Type: string:date-time:nullable
        public static DateTime? firstAccess;
        // Type: string:date-time:nullable
        public static DateTime? lastUpdate;
        // Type: integer:int64:nullable
        public static int legacyPortalUID;
        // Type: UserToUserContext
        public static UserToUserContext context;

        // Type: string
        public static string psnDisplayName;
        // Type: string
        public static string xboxDisplayName;
        // Type: string
        public static string fbDisplayName;
        // Type: boolean:nullable
        public static bool? showActivity;
        // Type: string
        public static string locale;
        // Type: boolean
        public static bool localeInheritDefault;
        // Type: integer:int64:nullable
        public static int lastBanReportId;
        // Type: boolean
        public static bool showGroupMessaging;
        // Type: string
        public static string profilePicturePath;
        // Type: string
        public static string profilePictureWidePath;
        // Type: string
        public static string profileThemeName;
        // Type: string
        public static string userTitleDisplay;
        // Type: string
        public static string statusText;
        // Type: string:date-time
        public static DateTime statusDate;
        // Type: string:date-time:nullable
        public static DateTime? profileBanExpire;
        // Type: string
        public static string blizzardDisplayName;

    }
}
