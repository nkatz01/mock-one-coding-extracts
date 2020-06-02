using System.Collections.Generic;
using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Alert { 
public class AlertService	
{
        private readonly IAlertDAO storage;

        public AlertService(IAlertDAO storage)
        {
            this.storage =  storage ;

        }

      // public int getStorageHash() => storage.GetHashCode();


        public (Guid, DateTime) RaiseAlert() {

            Guid guid = storage.AddAlert(DateTime.Now);
            return (guid , GetAlertTime(guid));

        }
	
    public DateTime GetAlertTime(Guid id)
    {
        return storage.GetAlert(id);
    }	
}
	
public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();
	
    public Guid AddAlert(DateTime time)
    {
        var id = Guid.NewGuid();
        alerts.Add( id, time);
        return id;
    }

        	
    public DateTime GetAlert(Guid id) => alerts[id];

        public override int GetHashCode()
        {
            int hash = 17;
            
            foreach (var kvp in alerts.OrderBy(i => i.Key))
            {//order is assumed to be ignored
                hash = hash * 23 + kvp.Key.GetHashCode();
                hash = hash * 23 + kvp.Value.GetHashCode(); }
            return hash;

         }


        public override bool Equals(object obj)
        {
            return Equals(obj as IAlertDAO);
        }

        public bool Equals(AlertDAO other)
        {
            if ((object)other != null)//order is assumed to be ignored
                return Enumerable.SequenceEqual(this.alerts.OrderBy(e => e.Key), other.alerts.OrderBy(e => e.Key));
            else
                return false;
 
        }

        public Guid GetKeyAtPos(int id)
        {

            return alerts.ElementAt(id).Key; 
        }
        public DateTime GetValAtPos(int id)
        {

            return alerts.ElementAt(id).Value;
        }

        public void Add(Guid guid, DateTime dt)
        {
            alerts.TryAdd(guid, dt); 
        }
    }

    public interface IAlertDAO
    {
        public Guid AddAlert(DateTime time);
        public DateTime GetAlert(Guid id);
        public DateTime GetValAtPos(int id);
        public Guid GetKeyAtPos(int id);

    }


}