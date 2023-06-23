using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTimeAPIFormat : MonoBehaviour
{
    public string abbreviation { get; set; }
    public string client_ip { get; set; }
    public string datetime { get; set; }
    public int day_of_week { get; set; }
    public int day_of_year { get; set; }
    public bool dst { get; set; }
    public object dst_from { get; set; }
    public int dst_offset { get; set; }
    public object dst_until { get; set; }
    public int raw_offset { get; set; }
    public string timezone { get; set; }
    public int unixtime { get; set; }
    public string utc_datetime { get; set; }
    public string utc_offset { get; set; }
    public int week_number { get; set; }
}
