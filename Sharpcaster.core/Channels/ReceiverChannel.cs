﻿using Sharpcaster.Core.Interfaces;
using System;
using Sharpcaster.Core.Models.ChromecastStatus;
using System.Threading.Tasks;
using Sharpcaster.Core.Messages.Receiver;

namespace Sharpcaster.Core.Channels
{
    /// <summary>
    /// ReceiverChannel, Receives ChromecastStatus, volume, starting and stopping application
    /// </summary>
    public class ReceiverChannel : StatusChannel<ReceiverStatusMessage, ChromecastStatus>, IReceiverChannel
    {
        public ReceiverChannel() : base("receiver")
        {
        }

        /// <summary>
        /// Checks the connection is well established
        /// </summary>
        /// <param name="ns">namespace</param>
        /// <returns>an application object</returns>
        public Task<ChromecastApplication> EnsureConnection(string ns)
        {
            throw new NotImplementedException();
        }

        public async Task<ChromecastStatus> GetChromecastStatusAsync()
        {
            return (await SendAsync<ReceiverStatusMessage>(new GetStatusMessage())).Status;
        }

        public async Task<ChromecastStatus> LaunchApplicationAsync(string applicationId)
        {
            return (await SendAsync<ReceiverStatusMessage>(new LaunchMessage() { ApplicationId = applicationId })).Status;
        }
    }
}
