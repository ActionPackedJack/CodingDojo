def shift_array_values_left(arr):
    for i in range(len(arr)-1):
        arr[i]=arr[i+1]
    arr.append(0)
    print arr

shift_array_values_left([12,3,5,0,7,18])