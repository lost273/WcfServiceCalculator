using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalculator {
    [ServiceContract]
    public interface ICalculator {
        #region Common Methods

        /// <summary>
        /// test of connection
        /// </summary>
        /// <returns> OK </returns>
        [OperationContract]
        string TestConnection();

        #endregion

        #region Arithmetic

        /// <summary>
        /// addition
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        [OperationContract]
        double Addition(double a, double b);

        /// <summary>
        /// subtraction
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        [OperationContract]
        double Subtraction(double a, double b);

        /// <summary>
        /// multiplication
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        [OperationContract]
        double Multiplication(double a, double b);

        /// <summary>
        /// division
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        [OperationContract]
        double Division(double a, double b);

        #endregion
    }
}
