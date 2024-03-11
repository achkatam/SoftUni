import time

from django.utils.deprecation import MiddlewareMixin


class MeasureExecutionTimeMiddleware(MiddlewareMixin):
    def process_request(self, request):
        self.start_time = time.time()
        request.cbm = True

    def process_response(self, request, response):
        self.end_time = time.time()
        print(
            f"Request method: {request.method} //+++??? from path: {request.path}  taken time: {self.end_time - self.start_time} seconds")
        return response


def measure_time(get_response):
    def middleware(request, *args, **kwargs):
        # Before request
        start_time = time.time()
        request.fbm = True

        result = get_response(request, *args, **kwargs)

        # After request
        end_time = time.time()
        print(
            f"Request method: {request.method} // from path: {request.path}  taken time: {end_time - start_time} seconds")

        return result

    return middleware
