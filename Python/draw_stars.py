def drawStars(arr):
    for i in range(len(arr)):
        if isinstance(arr[i],int):
            next=""
            for j in range(arr[i]):
                next+="*"
            print next
        if isinstance(arr[i],str):
            next=""
            for k in range(len(arr[i])):
                next+=arr[i][0]
            print next

drawStars ([1,2,3,4, "arf"])

