using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dinnerhub.Application.Common.Interfaces.Services;

namespace Dinnerhub.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}