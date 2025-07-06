using TMPro;
using UnityEngine.UI;

public class ActiveAlarmItem : RecyclingListViewItem
{
    public TextMeshProUGUI rowText;

    private ActiveAlarmData childData;
    public ActiveAlarmData ChildData
    {
        get { return childData; }
        set
        {
            childData = value;
            rowText.text = $"行号：{childData.Row}";
        }
    }
}


public struct ActiveAlarmData
{
    public string Row;

    public ActiveAlarmData(string row)
    {
        Row = row;
    }
}