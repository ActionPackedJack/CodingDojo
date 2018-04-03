def print_max_min_average_array_value(arr):
    min= arr[0]
    max= arr[0]
    sum=0
    for i in range(1,len(arr)):
        sum+=arr[i]
        if arr[i]>max:
            max=arr[i]
        if arr[i]<min:
            min=arr[i]
    print min
    print max
    print (sum/len(arr)+sum%len(arr))

print_max_min_average_array_value([12,15,11,9,11])