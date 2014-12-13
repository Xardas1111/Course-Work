from mysql.connector import connect


class AbstractTable:
    connector = connect(user='root', password='',
                        database='mydb')

    def name_resolver(self, name, table_name):
        if table_name.lower() == 'region':                  # REGION (id, name, country)
            if name.lower() == 'id':
                return 'Region_ID'
            elif name.lower() == 'name':
                return 'name'
            elif name.lower() == 'country':
                return 'Country_ID'
        elif table_name.lower() == 'accident_type':         # ACCIDENT TYPE (id, name)
            if name.lower() == 'id':
                return 'AccidentType_ID'
            elif name.lower() == 'name':
                return 'name'
        elif table_name.lower() == 'country':               # COUNTRY (id, name)
            if name.lower() == 'id':
                return 'Country_ID'
            elif name.lower() == 'name':
                return 'name'
        elif table_name.lower() == 'executed_actions':      # EXECUTED ACTIONS (id, DATE, description)
            if name.lower() == 'id':
                return 'ExecutedActions_ID'
            elif name.lower() == 'date':
                return 'date'
            elif name.lower() == 'description':
                return 'description'
            elif name.lower() == 'action':
                return 'action_id'
        elif table_name.lower() == 'object':                # OBJECT (id, name)
            if name.lower() == 'id':
                return 'object_id'
            elif name.lower() == 'name':
                return 'name'
            elif name.lower() == 'settlement':
                return 'settlement_id'
        elif table_name.lower() == 'recommended_actions':   # RECOMMENDED ACTIONS (id, action)
            if name.lower() == 'id':
                return 'RecommendedActions_ID'
            elif name.lower() == 'description':
                return 'description'
            elif name.lower() == 'name':
                return 'name'
            elif name.lower() == 'price':
                return 'price'
            elif name.lower() == 'accident_type':
                return 'AccidentType_ID'
        elif table_name.lower() == 'registration_form':     # REGISTRATION FORM (id, DATE, ...)
            if name.lower() == 'id':
                return 'RegistrationForm_ID'
            elif name.lower() == 'date':
                return 'date'
            elif name.lower() == 'located_money':
                return 'located_money'
            elif name.lower() == 'used_money':
                return 'used_money'
            elif name.lower() == 'object':
                return 'object_id'
            elif name.lower() == 'stage':
                return 'stage_stage_id'
            elif name.lower() == 'accident_type':
                return 'AccidentType_ID'
            elif name.lower() == 'commentary':
                return 'commentary'
        elif table_name.lower() == 'settlement':            # SETTLEMENT (id, name, country)
            if name.lower() == 'id':
                return 'settlement_id'
            elif name.lower() == 'name':
                return 'name'
            elif name.lower() == 'region':
                return 'region_id'
        elif table_name.lower() == 'stage':                 # STAGE (id, name)
            if name.lower() == 'id':
                return 'stage_id'
            elif name.lower() == 'name':
                return 'name'

    def transaction(self, action, name, data):
        print(action)
        if action == 'get':
            return self.select(name, data)
        elif action == 'update':
            return self.update(name, data)
        elif action == 'set':
            print('+')
            return self.insert(name, data)
        elif action == 'delete':
            return self.delete(name, data)
        else:
            return 'No such action'

    def select_fields(self, data, name):
        fields_string = ''
        for i in data:
            print(i, end='\t')
            fields_string += self.name_resolver(i, name) + ', '
        fields_string = fields_string[:-2]

        return fields_string

    def select_fields_data(self, data):
        fields_string = ''
        for i in data:
            fields_string += '"' + str(data[i]) + '", '
        fields_string = fields_string[:-2]

        return fields_string

    def select_fields_value(self, data, name):
        fields_string = ''
        for i in data:
            if i.lower() == 'id':
                continue
            fields_string += self.name_resolver(i, name) + '="' + str(data[i]) + '", '
        fields_string = fields_string[:-2]

        return fields_string

    def select(self, name, data):
        request = 'SELECT ' + self.select_fields(data, name) + ' FROM '+name+';'

        cursor = self.connector.cursor()
        cursor.execute(request)

        ansv = []
        names = [i for i in data]

        for i in cursor:
            temp = [j for j in i]
            ansv.append(dict(zip(names, temp)))

        return ansv

    def insert(self, name, data):
        request = 'INSERT INTO ' + name + \
                  ' (' + self.select_fields(data, name) + ') ' \
                  'VALUES (' + self.select_fields_data(data) + ');'
        print(request)
        cursor = self.connector.cursor()
        cursor.execute(request)
        data['id'] = ''

        self.connector.commit()

        return self.select(name, data)

    def update(self, name, data):
        request = 'UPDATE ' + name + \
                  ' SET ' + self.select_fields_value(data, name) + \
                  ' Where ' + self.name_resolver('id', name) \
                  + '=' + str(data['id']) + ';'
        print(request)
        cursor = self.connector.cursor()
        cursor.execute(request)

        self.connector.commit()

        return self.select(name, data)

    def delete(self, name, data):
        request = 'DELETE FROM ' + name + \
                  ' Where ' + self.name_resolver('id', name) \
                  + '=' + str(data['id']) + ';'
        print(request)
        cursor = self.connector.cursor()
        cursor.execute(request)

        self.connector.commit()

        return self.select(name, data)