// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetDueDateRepository
    {

        DateTime ValueDate { get; set; }
        int PaymentTermId { get; set; }

        /// <summary>
        /// Prepares and executes IGetDueDateRepository.
        /// </summary>
        DateTime Execute();
    }
}