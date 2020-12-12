using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.DT.Wpf.App
{

    /// <summary>
    /// 
    /// </summary>
    class Settings
    {

        #region Fields
        //No Fields
        #endregion

        #region Events
        //No Events
        #endregion

        #region Enums
        //No Enums
        #endregion

        #region Constructors
        //No Constructors
        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public System.Windows.Controls.Page ActivePage
        {
            get => this._activePage;
            set
            {
                if (this._activePage != value)
                {

                    this._activePage = value;
                    OnPropertyChanged(newValue: this._activePage);

                }
            }
        }
        private System.Windows.Controls.Page _activePage = null;

        #endregion

        #region Methods
        //No Methods
        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
