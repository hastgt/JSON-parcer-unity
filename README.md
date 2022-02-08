# JSON-url parser for unity
A simple json-url parser for unity with the help of [JsonDotNet](https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347), you need to download JsonDotNet (it's free) since json deserializer from unity is not good enough.

# **Usage:**

  1. Unpack JSONParser.unitypackage to your unity project
  2. Create new instance of JSONParseler in your desired script and give a type of custom class that should be filled with parsed data, also create new instance of desired class that should be filled with parsed data (first image)
  3. Assign desired class to the parsed data with a method RequestParsingAsync(url link to json that contains data), strictly use "await" whenever you request parsing (second image)
  4. On the fourth image you can see that desired class is filled with all data from json file.

![image](https://user-images.githubusercontent.com/44572610/153021507-9cc18624-c3b9-4ed3-944f-9ef72f48aed6.png)
![image](https://user-images.githubusercontent.com/44572610/153021560-e1da6ba4-3003-4e87-a5e1-2afe71369f42.png)
![image](https://user-images.githubusercontent.com/44572610/153018534-894f50ac-40b5-4ec3-8b8a-6a14428066be.png)
