
# if someStr != "BLANK":
#     someStr="BLANK"

try:
    someStr
except NameError:
    someStr = "BLANK"

def setFunc(l1):
    global someStr
    someStr = l1
    print(f"setting someStr={someStr}")


def getFunc():
    print(f"getting someStr={someStr}")
    return someStr
