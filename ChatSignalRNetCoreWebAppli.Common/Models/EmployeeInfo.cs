using System;
using System.Collections.Generic;
using System.Text;

namespace ChatSignalRNetCoreWebAppli.Common.Models
{
   public class EmployeeInfo
    {
        public const int MASS_RANGE = 4;
        public const int VISITOR_DEPARTMENT = 10000;

        //public EmployeeInfo();

        //public AutoOpenInfo AutoOpen { get; set; }
        public bool bAccessDenied { get; set; }
        public bool bEmailNotifications { get; set; }
        public bool bEnabledCount { get; set; }
        public bool bExtended { get; set; }
        public bool bHandicap { get; set; }
        public bool bHLXArm { get; set; }
        public bool bInterlockGroupImmunity { get; set; }
        public bool bMasterUser { get; set; }
        public bool bNewCounter { get; set; }
        public bool bValidDate { get; set; }
        public bool bVisitDate { get; set; }
        //public Color cColor { get; set; }
        public Dictionary<int, int> Counters { get; set; }
        public DateTime dtEmpDate { get; set; }
        public DateTime dtStartDate { get; set; }
        public DateTime dtStopDate { get; set; }
        public DateTime dtVisitDateTime { get; set; }
        public byte DualAuthenticationForceTimezone { get; set; }
        public byte DualAuthenticationImmunityTimezone { get; set; }
        public bool DualAuthenticationTimezoneIsEnabled { get; set; }
        //public EmployeeUserFieldInfo[] EmployeeUserFields { get; set; }
        public int EmpNumCompany { get; set; }
        //public eVisitorDisable eVisitorDisable { get; set; }
        public int iAntipassbackImmunity { get; set; }
        public int iCounter { get; set; }
        public int IdOutputsGroup { get; set; }
        public int IdTimeGroup { get; set; }
        public byte[] IdTZReader { get; set; }
        public int iEmpSlot { get; set; }
        public byte[] imgBytes { get; set; }
        public bool IsNameEmpty { get; set; }
        public int iVisitorDepartment { get; set; }
        public int iVisitorEnableArea { get; set; }
        public int iVisitorUser { get; set; }
        public string tAddress { get; set; }
        public string tCar { get; set; }
        public string tCodePIN { get; set; }
        public string tCodePINDuress { get; set; }
        public string tEmail { get; set; }
        public string tEmailAddress { get; set; }
        public string tEmailMsg { get; set; }
        public string tEmailSubject { get; set; }
        public string tEmailTo { get; set; }
        public string tFax { get; set; }
        public string tFirstName { get; set; }
        public string tHomeTel { get; set; }
        public string tIdentification { get; set; }
        public string tLastName { get; set; }
        public string tMiddleName { get; set; }
        public string tMobile { get; set; }
        public string tNotes { get; set; }
        public string tPhotoFile { get; set; }
        public string tPosition { get; set; }
        public string tTel { get; set; }
        public string tVisitorSpecialID { get; set; }
        public string tVisitorUser { get; set; }
        //public AccGrpInfo UserAccGrp { get; set; }
        //public UserCardAndCardGroupInfo UserCardAndCardGroup { get; set; }
        //public List<CardInfo> UserCards { get; }
        //public DepartmentInfo UserDepartment { get; set; }
        public byte wCardAndCardGroup { get; set; }
        public byte wParkingSubGroup { get; set; }

        //public override object Clone();
        //public bool IsCardExists(int cardID);
        //public void UserNotVisitor();
    }
}
