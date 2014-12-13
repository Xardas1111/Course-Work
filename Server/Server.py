import json
from flask import Flask, request
from database.tables import AbstractTable

app = Flask(__name__)


@app.route('/', methods=['POST', 'GET'])
def run_post():
    try:
        data = json.loads(request.get_data(as_text=True))

        table_data = AbstractTable().transaction(data['request'], data['table'], data['data'])

        return json.dumps(dict({
                'table': data['table'],
                'data': table_data
            }))

    except Exception as e:
        print(e)
        return e.__str__()


if __name__ == '__main__':
    app.run(host='0.0.0.0',
            port=8080)
