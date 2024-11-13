namespace dofus_unity_rendering_back.Models.Interfaces
{
    public interface IAdminSelectionEntry
    {
        IAdminSelectionEntryType adminSelectionEntryType
        {
            get;
        }

        string adminSelectionName
        {
            get;
        }

        int adminSelectionId
        {
            get;
        }

        int adminSelectionIconId
        {
            get;
        }

        uint adminSelectionTypeId
        {
            get;
        }
    }

}
