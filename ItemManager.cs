using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private readonly string _jsonFileUrl = "https://raw.githubusercontent.com/hastgt/JSON-parser-unity/main/JSONExample.json";

    private int _timeToShowItem;

    private readonly JSONParser<ChestData> _jsonParser = new JSONParser<ChestData>();
    [field: SerializeField]  private ChestData _chestData = new ChestData();


    private void Start()
    {
        ReceiveChestItems();
    }

    public async void ReceiveChestItems()
    {
        _chestData = await _jsonParser.RequestParsingAsync(_jsonFileUrl);
    }

}

