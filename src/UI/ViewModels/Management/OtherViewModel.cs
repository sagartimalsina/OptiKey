using JuliusSweetland.ETTA.Properties;
using log4net;
using Microsoft.Practices.Prism.Mvvm;

namespace JuliusSweetland.ETTA.UI.ViewModels.Management
{
    public class OtherViewModel : BindableBase
    {
        #region Private Member Vars

        private readonly static ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        
        #region Ctor

        public OtherViewModel()
        {
            LoadSettings();
        }
        
        #endregion
        
        #region Properties

        private bool debug;
        public bool Debug
        {
            get { return debug; }
            set { SetProperty(ref debug, value); }
        }

        public bool ChangesRequireRestart
        {
            get
            {
                return false;
            }
        }
        
        #endregion
        
        #region Methods

        private void LoadSettings()
        {
            Debug = Settings.Default.Debug;
        }

        public void ApplyChanges()
        {
            Settings.Default.Debug = Debug;
            Settings.Default.Save();
        }

        #endregion
    }
}
