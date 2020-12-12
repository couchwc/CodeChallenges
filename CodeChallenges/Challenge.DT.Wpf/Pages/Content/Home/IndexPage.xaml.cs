using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Challenge.DT.Wpf.Pages.Content.Home
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IndexPage : Page
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

        /// <summary>
        /// 
        /// </summary>
        public IndexPage()
        {

            Initialize();

        }

        /// <summary>
        /// 
        /// </summary>
        public IndexPage(MainWindow owner)
        {

            if (owner is null)
                throw new ArgumentNullException(paramName: nameof(owner));

            Initialize();
            
        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties
        //No Properties
        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        private void Initialize()
        {

            InitializeComponent();

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
