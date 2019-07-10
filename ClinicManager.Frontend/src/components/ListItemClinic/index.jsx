import React, { Component } from 'react';

import Card from '../Card';
import './listItemClinic.css';

export default class Index extends Component {
  render() {
    const {
      title,
      address,
      phoneNumber,
      url,
      email,
      specialisation,
      onDeleted,
      pictureGuid
    } = this.props;

    return (
      <Card
        style={{ margin: 5 }}
        title={title}
        address={address}
        phoneNumber={phoneNumber}
        url={url}
        email={email}
        specialisation={specialisation}
        onDeleted={onDeleted}
        pictureGuid={pictureGuid}
      />
    );
  }
}

/*
* <div className="info">
        <span>{title}</span>
        <span>{address}</span>
        <span>{phoneNumber}</span>
        <span>{email}</span>
        <span>{url}</span>
        <span>{specialisation}</span>
        <button
          type="button"
          className="btn-outline-danger btn-sm float-right"
          onClick={onDeleted}
        >
          <i className="fa fa-trash-o" />
        </button>
        <button
          type="button"
          className="btn-outline-danger btn-sm float-right"
          onClick={onDeleted}
        >
          <i className="fa fa-edit" />
        </button>
      </div>
* */
