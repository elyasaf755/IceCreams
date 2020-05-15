
namespace ViewModels
{
    public class StoreEditorBaseDesignModel : StoreEditorBaseViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreEditorBaseDesignModel Instance => new StoreEditorBaseDesignModel();

        #endregion

        #region Constructor

        public StoreEditorBaseDesignModel()
        {
            PopulateStore();
        }

        #endregion

    }
}
