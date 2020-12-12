using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Interfaces.CircleGame
{
    
    /// <summary>
    /// 
    /// </summary>
    public interface IGameService
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
        //No Properties
        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Arguments.CircleGame.SimulationOutput SimulateGame(
            Arguments.CircleGame.SimulationInput args);

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
