import React, { Component } from 'react';
import './ListItemClinic.css';

export default class ListItemClinic extends Component {
  render() {
    const {
      label,
      title,
      address,
      phoneNumber,
      url,
      email,
      specialisation,
      onDeleted
    } = this.props;

    return (
      <div className="info">
        <span>{title}</span>
        <span>{address}</span>
        <span>{phoneNumber}</span>
        <span>{email}</span>
        <span>{url}</span>
        <span>{specialisation}</span>
        <span>{label}</span>
        <button
          type="button"
          className="btn btn-outline-danger btn-sm float-right"
          onClick={onDeleted}
        >
          Кнопка удаление
        </button>
        <button
          type="button"
          className="btn btn-outline-danger btn-sm float-right"
          onClick={onDeleted}
        >
          Подробнее
        </button>
      </div>
    );
  }
}
