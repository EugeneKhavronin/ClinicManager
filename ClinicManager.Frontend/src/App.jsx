import React, { Component } from 'react';

import ListClinic from './components/ListClinic/ListClinic';
import Header from './header/Header';
import './header/header.css';
import './modal-window-more/modal-window-more.css';
import './index.css';

export default class App extends Component {
  maxId = 100;

  state = {
    clinicData: [
      this.createTodoItem(
        'Drink Coffee ',
        'Название клиники:МНТК ',
        'город:Обнинск ',
        'телефон: 84843941127 ',
        'URL адрес: http://localhost:5000/ ',
        'почта: @hadah ',
        'специализация клиник: хирургия '
      ),
      this.createTodoItem('Make Awesome App', 'Астро'),
      this.createTodoItem('Have a lunch', 'Клиника №1')
    ]
  };

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

  render() {
    const { clinicData } = this.state;
    return (
      <div>
        <Header />
        <ListClinic todos={clinicData} />
      </div>
    );
  }
}
