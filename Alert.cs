using System.Collections.Generic;
using System;

public class AlertService	
{
    private readonly AlertDAO storage = new AlertDAO();
	
    public Guid RaiseAlert() => storage.AddAlert(DateTime.Now);
	
    public DateTime GetAlertTime(Guid id)
    {
        return storage.GetAlert(id);
    }	
}
	
public class AlertDAO
{
    private readonly Dictionary<Uid, DateTime> alerts = new Dictionary<Uid, DateTime>();
	
    public Guid AddAlert(DateTime time)
    {
        var id = Guid.NewGuid();
        alerts.Add(id, time);
        return id;
    }
	
    public DateTime GetAlert(Guid id) => alerts[id];
}