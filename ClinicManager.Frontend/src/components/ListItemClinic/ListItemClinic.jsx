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
      onDeleted,
      onMore
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
          className="btn btn-primary"
          data-toggle="modal"
          data-target="#myModal"
          onClick={onMore}
        >
          Подробнее
        </button>
      </div>
    );
  }
}
