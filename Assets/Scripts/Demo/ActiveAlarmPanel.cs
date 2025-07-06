using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAlarmPanel : MonoBehaviour
{
    
    public RecyclingListView ActiveAlarmsScroll;
        
    public List<ActiveAlarmData> ActiveAlarmsList;
    
    // Start is called before the first frame update
    void Start()
    {
        
        ActiveAlarmsList = new List<ActiveAlarmData>();

        // 列表item更新回调
        ActiveAlarmsScroll.ItemCallback = PopulateItem;
        CreateList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    /// <summary>
    /// item更新回调
    /// </summary>
    /// <param name="self"></param>
    /// <param name="item">复用的item对象</param>
    /// <param name="rowIndex">行号</param>
    public void PopulateItem( RecyclingListViewItem item, int rowIndex)
    {
        var child = item as ActiveAlarmItem;
        if (child != null) child.ChildData = ActiveAlarmsList[rowIndex];
    }
        
    /// <summary>
    /// 创建列表
    /// </summary>
    public void CreateList()
    {
        var rowCnt = 100;
        ActiveAlarmsList.Clear();
        // 模拟数据
        string[] randomTitles = new[] {
            "23.ANSI 81-1 Underfreq.1.st",
            "黄沙百战穿金甲，不破楼兰终不还",
            "且将新火试新茶，诗酒趁年华",
            "苟利国家生死以，岂因祸福避趋之",
            "枫叶经霜艳，梅花透雪香",
            "夏虫不可语于冰",
            "落花无言，人淡如菊",
            "宠辱不惊，闲看庭前花开花落；去留无意，漫随天外云卷云舒",
            "衣带渐宽终不悔，为伊消得人憔悴",
            "从善如登，从恶如崩",
            "欲穷千里目，更上一层楼",
            "草木本无意，荣枯自有时",
            "纸上得来终觉浅，绝知此事要躬行",
            "不是一番梅彻骨，怎得梅花扑鼻香",
            "青青子衿，悠悠我心",
            "瓜田不纳履，李下不正冠"
        };
        for (int i = 0; i < rowCnt; ++i)
        {
            ActiveAlarmsList.Add(new ActiveAlarmData($"{i.ToString()}  {randomTitles[Random.Range(0, randomTitles.Length)]}"));
        }

        // 设置数据，此时列表会执行更新
        ActiveAlarmsScroll.RowCount = ActiveAlarmsList.Count;
    }
        
    /// <summary>
    /// 清空列表
    /// </summary>
    public void ClearList()
    {
        ActiveAlarmsList.Clear();
        ActiveAlarmsScroll.Clear();
    }
}
