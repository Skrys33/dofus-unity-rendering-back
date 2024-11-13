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

with open('C:/Users/enzos/source/repos/dofus-unity-rendering-back/Data/MonstersRoot.json') as file:
    data = json.load(file)

clearDic(data)

with open('C:/Users/enzos/source/repos/dofus-unity-rendering-back/Data/MonstersRoot.json', "w") as outfile:
    json.dump(data, outfile, indent=4)