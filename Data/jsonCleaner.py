import json

def clearDic(data):
    if isinstance(data, dict):
        for key, value in data.items():
            #print(key, type(value))
            if isinstance(value, dict):
                if "Array" in value:
                    data[key] = value["Array"]
                clearDic(value)
            elif isinstance(value, list):
                for v in value:
                    # print(v)
                    clearDic(v)

with open('C:/Users/enzos/source/repos/dofus-unity-rendering-back/Data/SpellLevelsRoot.json', encoding="utf-8") as file:
    data = json.load(file)

clearDic(data)

with open('C:/Users/enzos/source/repos/dofus-unity-rendering-back/Data/SpellLevelsRoot.json', "w", encoding="utf-8") as outfile:
    json.dump(data, outfile, indent=4)