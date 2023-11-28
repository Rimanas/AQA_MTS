namespace Classes.Models;

public class Person
{
    // Р‘Р»РѕРє РїРѕР»РµР№ (РїРµСЂРµРјРµРЅРЅС‹С…)
    public string name = "Undefined";   // РёРјСЏ
    public int age;                     // РІРѕР·СЂР°СЃС‚

    // Р‘Р»РѕРє РєРѕРЅСЃС‚СЂСѓРєС‚РѕСЂР°

    // Р‘Р»РѕРє РјРµС‚РѕРґРѕРІ Рё СЃРІРѕР№СЃС‚РІ
    public void Print()
    {
        Console.WriteLine($"РРјСЏ: {name}  Р’РѕР·СЂР°СЃС‚: {age}");
    }
}