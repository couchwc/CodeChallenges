using Challenge.Core.Arguments.CircleGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Services.CircleGame
{

    /// <summary>
    /// 
    /// </summary>
    public class GameService :
        BaseService,
        Interfaces.CircleGame.IGameService
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
        public GameService()
        {
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
        /// <param name="args"></param>
        /// <returns></returns>
        public SimulationOutput SimulateGame(
            SimulationInput args)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
