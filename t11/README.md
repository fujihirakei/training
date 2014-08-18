# 問題 11
===
以下のクラスのインスタンスを ComboBox の選択項目として表示する。
項目数は 2 つ以上。

``` C#
public class Item
{
    public Item(string name, int value)
    {
        this.Name = name;
        this.Value = value;
    }
    
    public string Name { get; set; }
    
    public int Value { get; set; }
}
```

ComboBox の選択項目には Name プロパティを表示する。選択が変わったタイミングで選択している項目の Value プロパティの値をメッセージ表示する。

- http://msdn.microsoft.com/ja-jp/library/system.windows.controls.combobox.aspx
