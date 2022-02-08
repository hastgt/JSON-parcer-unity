# JSON-url parser for unity
A simple json-url parser for unity with the help of [JsonDotNet](https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347)

# **Usage:**

  1. Unpack JSONParser.unitypackage to your unity project
  2. Create new instance of JSONParseler in your desired script and give a type of custom class that should be filled with parsed data, also create new instance of desired class that should be filled with parsed data (first image)
  3. Assign desired class to the parsed data with a method RequestParsingAsync(url link to json that contains data), strictly use "await" whenever you request parsing (second image)
  4. On the fourth image you can see that desired class is filled with all data from json file.

![image](https://user-images.githubusercontent.com/44572610/153015330-1681f154-59a5-469d-b4c1-cee8e5c0e3d9.png)
![image](https://user-images.githubusercontent.com/44572610/153016232-7a954a53-5052-4820-876c-5c98adccc249.png)
![image](https://user-images.githubusercontent.com/44572610/153018534-894f50ac-40b5-4ec3-8b8a-6a14428066be.png)
