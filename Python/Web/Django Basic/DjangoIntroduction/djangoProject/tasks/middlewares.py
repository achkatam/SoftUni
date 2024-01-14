import time


# Just simple explanation and example how middlewares work
# Runs before and after the execution of the file
def measure_time(get_response):
    def middleware(request, *args, **kwargs):
        print("Before view")
        start_time = time.time()
        result = get_response(request, *args, **kwargs)
        print("After view")
        end_time = time.time()

        print(f"Request took {end_time - start_time} seconds")
        return result

    return middleware
