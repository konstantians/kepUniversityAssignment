namespace KEPAssignment
{
    public static class StaticData
    {
        public static bool OpenViewCitizenForm { get; set; } = false;
        public static bool OpenViewPetitionForm { get; set; } = false;
        public static bool OpenAddCitizenForm { get; set; } = false;
        public static bool OpenAddPetitionForm { get; set; } = false;
        public static bool OpenHomeForm { get; set; } = false;
        //
        public static bool OpenCitizenDetailsForm { get; set; } = false;
        public static string CitizenDetailsFormAfmValue { get; set; } = "";
        //
        //
        public static bool OpenPetitionDetailsForm { get; set; } = false;
        public static int PetitionIdValue { get; set; } = -1;
        //
        public static bool UnsavedChanges { get; set; } = false;
        //Filters Petition
        public static string PetitionTypeFilter { get; set; } = "";
        public static string PetitionDateFilter { get; set; } = "";
        public static string PetitionStatusFilter { get; set; } = "";
        public static string SearchByIdFilter { get; set; } = "";
        public static string SearchByAliasFilter { get; set; } = "";
        //Filters Citizen
        public static string SearchByAFMFilter { get; set; } = "";
        public static string SearchByAMKAFilter { get; set; } = "";
        public static string SearchByFullNameFilter { get; set; } = "";
        public static string SearchByAddressFilter { get; set; } = "";
        public static string SearchByEmailFilter { get; set; } = "";
        public static string SearchByPhoneNumberFilter { get; set; } = "";
        public static bool FilterAdded { get; set; } = false;

        public static void ClearAllPetitionFilters()
        {
            PetitionTypeFilter = "";
            PetitionDateFilter = "";
            PetitionStatusFilter = "";
            SearchByIdFilter = "";
            SearchByAliasFilter = "";
        }

        public static void ClearAllCitizensFilters()
        {
            SearchByAFMFilter = "";
            SearchByAFMFilter = "";
            SearchByFullNameFilter = "";
            SearchByAddressFilter = "";
            SearchByEmailFilter = "";
            SearchByPhoneNumberFilter = "";
        }
    }
}
