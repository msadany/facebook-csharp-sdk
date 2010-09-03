// <copyright file="FacebookAsyncResultTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Threading;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookAsyncResult</summary>
    [PexClass(typeof(FacebookAsyncResult))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookAsyncResultTest
    {
        /// <summary>Test stub for AsyncState</summary>
        [PexMethod(MaxConditions = 1000)]
        public void AsyncStateGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            object result = target.AsyncState;
            // TODO: add assertions to method FacebookAsyncResultTest.AsyncStateGet(FacebookAsyncResult)
        }

        /// <summary>Test stub for AsyncWaitHandle</summary>
        [PexMethod]
        public void AsyncWaitHandleGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            WaitHandle result = target.AsyncWaitHandle;
            // TODO: add assertions to method FacebookAsyncResultTest.AsyncWaitHandleGet(FacebookAsyncResult)
        }

        /// <summary>Test stub for CompletedSynchronously</summary>
        [PexMethod]
        public void CompletedSynchronouslyGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            bool result = target.CompletedSynchronously;
            // TODO: add assertions to method FacebookAsyncResultTest.CompletedSynchronouslyGet(FacebookAsyncResult)
        }

        /// <summary>Test stub for .ctor(Object, Object, WaitHandle, Boolean, Boolean, FacebookApiException)</summary>
        [PexMethod]
        public FacebookAsyncResult Constructor(
            object result,
            object asyncState,
            WaitHandle asyncWaitHandle,
            bool completedSynchronously,
            bool isCompleted,
            FacebookApiException error
        )
        {
            FacebookAsyncResult target
               = new FacebookAsyncResult(result, asyncState, asyncWaitHandle, 
                                         completedSynchronously, isCompleted, error);
            return target;
            // TODO: add assertions to method FacebookAsyncResultTest.Constructor(Object, Object, WaitHandle, Boolean, Boolean, FacebookApiException)
        }

        /// <summary>Test stub for Error</summary>
        [PexMethod]
        public void ErrorGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            FacebookApiException result = target.Error;
            // TODO: add assertions to method FacebookAsyncResultTest.ErrorGet(FacebookAsyncResult)
        }

        /// <summary>Test stub for IsCompleted</summary>
        [PexMethod]
        public void IsCompletedGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            bool result = target.IsCompleted;
            // TODO: add assertions to method FacebookAsyncResultTest.IsCompletedGet(FacebookAsyncResult)
        }

        /// <summary>Test stub for Result</summary>
        [PexMethod]
        public void ResultGet([PexAssumeUnderTest]FacebookAsyncResult target)
        {
            object result = target.Result;
            // TODO: add assertions to method FacebookAsyncResultTest.ResultGet(FacebookAsyncResult)
        }
    }
}
