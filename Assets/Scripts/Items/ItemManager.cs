using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private readonly string _jsonFileUrl = "https://github.com/hastgt/JSON-parcer-unity/blob/main/JSONExample.json";

    private int _timeToShowItem;

    private readonly JSONParser<ChestData> _jsonParser = new JSONParser<ChestData>();
    private ChestData _chestData = new ChestData();


    private void Start()
    {
        ReceiveChestItems();
    }

    public async void ReceiveChestItems()
    {
        _chestData = await _jsonParser.RequestParsingAsync(_jsonFileUrl);
    }

}

