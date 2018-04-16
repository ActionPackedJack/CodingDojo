# from flask import Flask, request, redirect, render_template, session, flash
# from mysqlconnection import MySQLConnector
# app = Flask(__name__)
# mysql = MySQLConnector(app,'friendsdb')
# @app.route('/')
# def index():
#     friends = mysql.query_db("SELECT * FROM friends")
#     print friends
#     return render_template('index.html')
# @app.route('/friends', methods=['POST'])
# def create():
#     return redirect('/')
# app.run(debug=True)

from flask import Flask, request, redirect, render_template, session, flash
from mysqlconnection import MySQLConnector
app= Flask(__name__)
mysql= MySQLConnector(app, 'friendsdb')
@app.route('/')
def index ():
    friends = mysql.query_db("SELECT * FROM friends")
    print friends
    return render_template('index.html', friends=friends)
@app.route('/friends', methods=['POST'])
def create():
    first_name=request.form["first_name"]
    last_name=request.form["last_name"]
    occupation= request.form["occupation"]
    query= "INSERT INTO friends (first_name, last_name, occupation, created_at, updated_at) VALUES ('{}', '{}', '{}', NOW(), NOW())".format(first_name,last_name, occupation)
    mysql.query_db(query)
    return redirect('/')
app.run(debug=True)