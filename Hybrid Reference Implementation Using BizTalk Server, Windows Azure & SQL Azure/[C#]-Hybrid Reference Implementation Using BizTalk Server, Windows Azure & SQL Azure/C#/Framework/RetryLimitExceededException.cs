﻿//==================================================================================
// Contoso Cloud Integration Service Layer Solution
//
// The Framework library is a set of common components shared across multiple
// projects in the Contoso Cloud Integration solution.
//
//==================================================================================
// Copyright © 2011 Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE. YOU BEAR THE RISK OF USING IT.
//=================================================================================
namespace Contoso.Cloud.Integration.Framework
{
    #region Using references
    using System;
    using Contoso.Cloud.Integration.Framework.Properties;
    #endregion

    /// <summary>
    /// The special type of exception that provides managed exit from a retry loop. The user code can use this
    /// exception to notify the retry policy that no further retry attempts are required.
    /// </summary>
    [Serializable]
    public sealed class RetryLimitExceededException : Exception
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the RetryLimitExceededException class with a default error message.
        /// </summary>
        public RetryLimitExceededException()
            : this(Resources.ExceptionTextRetryLimitExceeded)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RetryLimitExceededException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public RetryLimitExceededException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RetryLimitExceededException class with a reference to the inner exception
        /// that is the cause of this exception.
        /// </summary>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public RetryLimitExceededException(Exception innerException)
            : base(innerException != null ? innerException.Message : Resources.ExceptionTextRetryLimitExceeded, innerException)
        {
        } 
        #endregion
    }
}
