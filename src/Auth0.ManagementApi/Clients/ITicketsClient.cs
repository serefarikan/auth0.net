﻿using System.Threading.Tasks;
using Auth0.ManagementApi.Models;

namespace Auth0.ManagementApi.Clients
{
    /// <summary>
    /// Contains all the methods to call the /tickets endpoints.
    /// </summary>
    public interface ITicketsClient
    {
        /// <summary>
        /// Creates an email verification ticket.
        /// </summary>
        /// <param name="request">The <see cref="EmailVerificationTicketRequest"/> containing the details of the ticket to create.</param>
        /// <returns>The <see cref="Ticket"/>.</returns>
        Task<Ticket> CreateEmailVerificationTicketAsync(EmailVerificationTicketRequest request);

        /// <summary>
        /// Creates a password change ticket.
        /// </summary>
        /// <param name="request">The <see cref="PasswordChangeTicketRequest"/> containing the details of the ticket to create.</param>
        /// <returns>The <see cref="Ticket"/>.</returns>
        Task<Ticket> CreatePasswordChangeTicketAsync(PasswordChangeTicketRequest request);
    }
}