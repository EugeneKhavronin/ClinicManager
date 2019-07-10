import React, { Component } from 'react';
// eslint-disable-next-line import/no-named-as-default
import ListClinic from './components/ListClinic/ListClinic';

export default class App extends Component {
  maxId = 100;

  state = {
    clinicData: [
      this.createTodoItem(
        'Текст клиники ',
        'Название клиники:МНТК, ',
        'город:Обнинск, ',
        'телефон: 84843941127, ',
        'URL адрес: http://localhost:5000/, ',
        'почта: @hadah, ',
        'специализация клиник: хирургия, '
      ),
      this.createTodoItem('Make Awesome App', 'Астро'),
      this.createTodoItem('Have a lunch', 'Клиника №1')
    ]
  };

  // eslint-disable-next-line react/sort-comp
  createTodoItem(
    label,
    title,
    address,
    phoneNumber,
    url,
    email,
    specialisation
  ) {
    return {
      // eslint-disable-next-line no-plusplus
      clinicGuid: this.maxId++,
      label,
      title,
      address,
      phoneNumber,
      url,
      email,
      specialisation,
      pictureGuid: 'string'
    };
  }

  deleteItem = clinicGuid => {
    this.setState(({ clinicData }) => {
      const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);

      const before = clinicData.slice(0, idx);
      const after = clinicData.slice(idx + 1);
      const newArray = [...before, ...after];
      return { clinicData: newArray };
    });
  };

  render() {
    const { clinicData } = this.state;
    return <ListClinic todos={clinicData} onDeleted={this.deleteItem} />;
  }
}
