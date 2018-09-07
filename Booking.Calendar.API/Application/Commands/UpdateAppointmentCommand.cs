﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Calendar.API.Application.Commands
{
    public class UpdateAppointmentCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string Categoria { get; set; }
        public string ClassEvent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
