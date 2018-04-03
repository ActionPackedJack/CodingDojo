def printMaxOfArray(arr):
    max=arr[0]
    for i in range(len(arr)-1):
        if arr[i]>max:
            max=arr[i]
    print max

printMaxOfArray([0,2,5,7,4])