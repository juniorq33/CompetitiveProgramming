n = int(input())

i = 1

decreasing = True
increasing = True
previousString = ""

while(i <= n):
	currentString = input()

	if((i >= 2 and decreasing == True)):
		if(previousString < currentString):
			decreasing = False


	if((i >= 2 and increasing == True)):
		if(previousString > currentString):
			increasing = False
	
	previousString = currentString
	i = i + 1

if(decreasing == True):
	print("DECREASING")
if(increasing):
	print("INCREASING")
if(decreasing == False and increasing == False):
	print("NEITHER")