using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class AppointmentData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<Appointment> GetAppointments(DateTime from, DateTime to)
        {
            List<Appointment> appointments = new List<Appointment>();
            to = to.Add(new TimeSpan(1, 0, 0, 0));
            from = from.Add(new TimeSpan(-1, 0, 0, 0));
            try
            {
                appointments = (from a in entities.Appointments select a).ToList();
                if (appointments.Count > 0)
                {
                    return appointments.Where(i => i.AppointmentDate > from && i.AppointmentDate < to).ToList();
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); 
            }
            return appointments;
        }

        public bool AddSchedule(Appointment model)
        {
            try
            {
                entities.Appointments.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public bool UpdateSchedule(Appointment model)
        {
            try
            {
                Appointment appointment = entities.Appointments.Where(x => x.AppointmentId == model.AppointmentId).SingleOrDefault();
                if (appointment != null)
                {
                    entities.Entry(appointment).CurrentValues.SetValues(model);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public bool DeleteSchedule(int id)
        {
            try
            {
                Appointment appointment = entities.Appointments.Where(x => x.AppointmentId == id).SingleOrDefault();
                if (appointment != null)
                {
                    entities.Appointments.Remove(appointment);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }
    }
}
