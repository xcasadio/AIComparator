using System;
using System.Collections.Generic;
using System.Text;


namespace CasaEngine.AI.Reinforcement_Learning.QLearning
{
    /// <summary>
    /// 
    /// </summary>
    public class QLearner
    {
        #region Fields

        QLearning m_QL = new QLearning();

        #endregion

        #region Properties

        /// <summary>
        /// Gets QLearning
        /// </summary>
        public QLearning QLearning
        {
            get { return m_QL; }
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        public void Update(float dt)
        {

            //string newState = string.Empty;
            //m_QL.Learn(state_, action_, newState);
            //m_QL.Learn()
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent_"></param>
        /// <param name="currentState_"></param>
        public void Update(IQAgent agent_, string currentState_)
        {
            m_QL.Learn(agent_, currentState_);
        }

        #endregion
    }
}
