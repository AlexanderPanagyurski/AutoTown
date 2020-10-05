using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Common
{
    public class AttributesConstraints
    {
        #region Car
        public const byte MakeMaxLength = 30;
        public const byte ModelMaxLength = 30;
        public const short YearMaxLength = 2100;
        public const string PriceMinValue = "0";
        public const string PriceMaxValue = "79228162514264337593543950335";
        public const int MileageMaxValue = 500_000;
        public const int HorsePowerMaxValue = 2500;
        public const short CarDescriptionMaxLength = 1000;
        #endregion

        #region CarComment
        public const byte CarCommentUserFullNameMaxLength = 80;
        public const byte PhoneNumberMaxLength = 10;
        public const byte EmailMaxLength = 32;
        public const short ContentMaxLength = 500;

        #endregion

        #region User
        public const byte UserNameMaxLength = 25;
        #endregion

        #region City, Region, Country
        public const byte CityNameMaxLength = byte.MaxValue;
        public const byte RegionNameMaxLength = byte.MaxValue;
        public const byte CountryNameMaxLength = 60;
        #endregion

        #region ChatMessage, ChatConversation
        public const byte MessageTextMaxLength = byte.MaxValue;
        #endregion

        #region CarEngine
        public const short HorsePowerMinValue = 70;

        public const double EngineDisplacementMaxValue = 8.00;

        public const double EngineDisplacementMinValue = 1.00;
        #endregion
    }
}
