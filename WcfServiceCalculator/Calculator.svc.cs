using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalculator {
    public class Calculator : ICalculator {
        #region Common Methods

        /// <summary>
        /// test of connection
        /// </summary>
        /// <returns> OK </returns>
        public string TestConnection() {
            return "OK";
        }

        #endregion

        #region Arithmetic

        /// <summary>
        /// addition
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        public double Addition(double a, double b) {
            return a + b;
        }

        /// <summary>
        /// subtraction
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        public double Subtraction(double a, double b) {
            return a - b;
        }

        /// <summary>
        /// multiplication
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        public double Multiplication(double a, double b) {
            return a * b;
        }

        /// <summary>
        /// division
        /// </summary>
        /// <param name="a"> 1 </param>
        /// <param name="b"> 2 </param>
        /// <returns> result </returns>
        public double Division(double a, double b) {
            return a / b;
        }

        #endregion
    }
}
