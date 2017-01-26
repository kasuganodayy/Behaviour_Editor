using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    [XmlType("Action")]
    public class Action
    {
        [XmlAttribute("name")]
        public string m_name;
        [XmlAttribute("target")]
        public string m_target;
        [XmlAttribute("minDuration")]
        public decimal m_minDuration;
        [XmlAttribute("maxDuration")]
        public decimal m_maxDuration;
    }

    public class ScheduledAction
    {
        [XmlAttribute("type")]
        public string m_type;
        [XmlAttribute("weight")]
        public decimal m_weight;
    }

    [XmlType("Entry")]
    public class ActionEntry
    {
        [XmlAttribute("name")]
        public string m_name;
        [XmlAttribute("type")]
        public string m_type;
        [XmlAttribute("template")]
        public string m_template;
        [XmlAttribute("startTime")]
        public decimal m_startTime;
        [XmlElement("Action")]
        public List<ScheduledAction> m_scheAction;
    }

    [XmlType("Schedule")]
    public class Schedule
    {
        [XmlAttribute("name")]
        public string m_name;
        [XmlElement("Entry")]
        public List<ActionEntry> m_entryList;
    }

    [Serializable, XmlRoot("Scheduling")]
    public class Scheduling
    {
        //[XmlElement("Actions")]
        //List<Action> m_actions { get; set; }
        //[XmlElement("ScheduleEntryTemplates")]
        //List<ActionEntry> m_entryTemplates;
        //[XmlElement("Schedules")]
        //List<Schedule> m_schedules;

        List<Action> Actions { get; set; }
        List<ActionEntry> ScheduleEntryTemplates { get; set; }
        List<Schedule> Schedules { get; set; }
    }
}
