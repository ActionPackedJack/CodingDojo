from flask import Flask, render_template, request
app = Flask(__name__)

@app.route('/')
def openpage():
    return render_template('hello_world.html')

app.run(debug=True)
